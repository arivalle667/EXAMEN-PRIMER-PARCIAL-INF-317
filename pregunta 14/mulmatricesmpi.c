#include <mpi.h> 
#include <stdio.h> 
#include <stdlib.h> 
 
#define N 4 // Tamaño de las matrices (NxN) 
 
void fillMatrix(int matrix[N][N]) { 
    for (int i = 0; i < N; i++) { 
        for (int j = 0; j < N; j++) { 
            matrix[i][j] = rand() % 10; 
        } 
    } 
} 
 
void printMatrix(int matrix[N][N]) { 
    for (int i = 0; i < N; i++) { 
        for (int j = 0; j < N; j++) { 
            printf("%d ", matrix[i][j]); 
        } 
        printf("\n"); 
    } 
} 
 
int main(int argc, char** argv) { 
    int rank, size; 
     
    // Inicializar MPI 
    MPI_Init(&argc, &argv); 
    MPI_Comm_rank(MPI_COMM_WORLD, &rank); 
    MPI_Comm_size(MPI_COMM_WORLD, &size); 
 
    int A[N][N], B[N][N], C[N][N]; 
     
    // El proceso 0 inicializa las matrices A y B 
    if (rank == 0) { 
        fillMatrix(A); 
        fillMatrix(B); 
 
        printf("Matriz A:\n"); 
        printMatrix(A); 
 
        printf("Matriz B:\n"); 
        printMatrix(B); 
    } 
 
    // Broadcast de la matriz B a todos los procesos 
    MPI_Bcast(B, N*N, MPI_INT, 0, MPI_COMM_WORLD); 
 
    // Determinar el número de filas por proceso 
    int filasPorProceso = N / size; 
    int filaInicio = rank * filasPorProceso; 
    int filaFin = (rank == size - 1) ? N : filaInicio + filasPorProceso; 
 
    // Enviar las filas de A correspondientes a cada proceso 
    if (rank == 0) { 
        for (int i = 1; i < size; i++) { 
            int startRow = i * filasPorProceso; 
            int endRow = (i == size - 1) ? N : startRow + filasPorProceso; 
            MPI_Send(&A[startRow][0], (endRow - startRow) * N, MPI_INT, i, 0, MPI_COMM_WORLD); 
        } 
    } else { 
        MPI_Recv(&A[filaInicio][0], (filaFin - filaInicio) * N, MPI_INT, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE); 
    } 
 
    // Calcular la parte de la matriz C correspondiente a cada proceso 
    for (int i = filaInicio; i < filaFin; i++) { 
        for (int j = 0; j < N; j++) { 
            C[i][j] = 0; 
            for (int k = 0; k < N; k++) { 
                C[i][j] += A[i][k] * B[k][j]; 
            } 
        } 
    } 
 
    // Recolectar los resultados en el proceso 0 
    if (rank == 0) { 
        for (int i = 1; i < size; i++) { 
            int startRow = i * filasPorProceso; 
            int endRow = (i == size - 1) ? N : startRow + filasPorProceso; 
            MPI_Recv(&C[startRow][0], (endRow - startRow) * N, MPI_INT, i, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE); 
        } 
 
        // Imprimir la matriz resultante C 
        printf("Matriz C (Resultado de A x B):\n"); 
        printMatrix(C); 
    } else { 
        MPI_Send(&C[filaInicio][0], (filaFin - filaInicio) * N, MPI_INT, 0, 0, MPI_COMM_WORLD); 
    } 
 
    // Finalizar MPI 
    MPI_Finalize(); 
    return 0; 
}
