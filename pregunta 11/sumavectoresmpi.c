#include <mpi.h> 
#include <stdio.h> 
#include <stdlib.h> 
 
int main(int argc, char** argv) { 
    int size, rank; 
 
    // Inicializar MPI 
    MPI_Init(&argc, &argv); 
    MPI_Comm_size(MPI_COMM_WORLD, &size); 
    MPI_Comm_rank(MPI_COMM_WORLD, &rank); 
 
    int n = 10;  // Longitud de los vectores (puedes cambiar este valor) 
    int vectorA[n], vectorB[n], resultado[n]; 
     
    // Inicializar los vectores en el proceso maestro (rank 0) 
    if (rank == 0) { 
        printf("Vector A: "); 
        for (int i = 0; i < n; i++) { 
            vectorA[i] = i + 1; 
            printf("%d ", vectorA[i]); 
        } 
        printf("\n"); 
 
        printf("Vector B: "); 
        for (int i = 0; i < n; i++) { 
            vectorB[i] = (i + 1) * 2; 
            printf("%d ", vectorB[i]); 
        } 
        printf("\n"); 
    } 
 
    // Dividir el trabajo entre los procesos 
    int localSum[n / 2];  // Para almacenar las sumas parciales 
 
    // Enviar los datos a los procesos secundarios 
    if (rank == 1 || rank == 2) { 
        int indices[n / 2]; 
        int count = 0; 
 
        // Determinar las posiciones a sumar (pares o impares) 
        for (int i = rank - 1; i < n; i += 2) { 
            if (rank == 1 && i % 2 != 0) { 
                indices[count] = i; 
                count++; 
            } else if (rank == 2 && i % 2 == 0) { 
                indices[count] = i; 
                count++; 
            } 
        } 
 
        // Recibir datos del maestro y calcular la suma parcial 
        MPI_Bcast(vectorA, n, MPI_INT, 0, MPI_COMM_WORLD); 
        MPI_Bcast(vectorB, n, MPI_INT, 0, MPI_COMM_WORLD); 
 
        for (int i = 0; i < count; i++) { 
            int index = indices[i]; 
            localSum[i] = vectorA[index] + vectorB[index]; 
        } 
 
        // Enviar el resultado parcial de nuevo al maestro 
        MPI_Send(localSum, count, MPI_INT, 0, rank, MPI_COMM_WORLD); 
    } 
     
    // Recibir resultados parciales en el proceso maestro (rank 0) 
    if (rank == 0) { 
        int recvBuffer[n / 2]; 
        for (int i = 1; i <= 2; i++) { 
            MPI_Recv(recvBuffer, n / 2, MPI_INT, i, i, MPI_COMM_WORLD, MPI_STATUS_IGNORE); 
 
            // Colocar los resultados en las posiciones correctas 
            int index = (i == 1) ? 1 : 0;  // Comenzar en impar para rank 1 y par para rank 2 
            for (int j = 0; j < n / 2; j++) { 
                resultado[index] = recvBuffer[j]; 
                index += 2; 
            } 
        } 
 
        // Imprimir el resultado final 
        printf("Resultado de la suma: "); 
        for (int i = 0; i < n; i++) { 
            printf("%d ", resultado[i]); 
        } 
        printf("\n"); 
    } 
 
    // Finalizar MPI 
    MPI_Finalize(); 
    return 0; 
}
