#include <mpi.h> 
#include <stdio.h> 
#include <string.h> 
 
int main(int argc, char** argv) { 
    int rank, size; 
     
    // Inicializar MPI 
    MPI_Init(&argc, &argv); 
    MPI_Comm_rank(MPI_COMM_WORLD, &rank); 
    MPI_Comm_size(MPI_COMM_WORLD, &size); 
 
    const int MAX_STRING_LEN = 100; 
    const int VECTOR_SIZE = 6; 
    char vector[VECTOR_SIZE][MAX_STRING_LEN]; 
     
    // El proceso 0 inicializa y distribuye los datos 
    if (rank == 0) { 
        // Inicializar el vector de cadenas 
        strncpy(vector[0], "cadena_0", MAX_STRING_LEN); 
        strncpy(vector[1], "cadena_1", MAX_STRING_LEN); 
        strncpy(vector[2], "cadena_2", MAX_STRING_LEN); 
        strncpy(vector[3], "cadena_3", MAX_STRING_LEN); 
        strncpy(vector[4], "cadena_4", MAX_STRING_LEN); 
        strncpy(vector[5], "cadena_5", MAX_STRING_LEN); 
 
        // Enviar el vector completo a los procesos 1 y 2 
        for (int i = 1; i <= 2; i++) { 
            MPI_Send(vector, VECTOR_SIZE * MAX_STRING_LEN, MPI_CHAR, i, 0, MPI_COMM_WORLD); 
        } 
    }  
    else if (rank == 1 || rank == 2) { 
        // Recibir el vector de cadenas 
        char recv_vector[VECTOR_SIZE][MAX_STRING_LEN]; 
        MPI_Recv(recv_vector, VECTOR_SIZE * MAX_STRING_LEN, MPI_CHAR, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE); 
 
        // Desplegar los datos correspondientes a las posiciones pares o impares 
        printf("Proceso %d desplegando cadenas:\n", rank); 
        for (int i = (rank == 1 ? 0 : 1); i < VECTOR_SIZE; i += 2) { 
            printf("Proceso %d - %s\n", rank, recv_vector[i]); 
        } 
    } 
 
    // Finalizar MPI 
    MPI_Finalize(); 
    return 0; 
}
