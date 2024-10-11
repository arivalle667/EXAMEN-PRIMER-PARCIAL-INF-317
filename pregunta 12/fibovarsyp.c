#include <stdio.h> 
#include <stdlib.h> 
#include <omp.h> 
 
int main() { 
    int n; 
 
    // Solicitar al usuario que ingrese la cantidad de términos 
    printf("Ingrese la cantidad de términos de la serie de Fibonacci a calcular: "); 
    scanf("%d", &n); 
 
    // Validar el valor de n 
    if (n < 2) { 
        printf("Por favor, ingrese un número mayor o igual a 2.\n"); 
        return 1; 
    } 
 
    int* fibonacci = (int*)malloc(n * sizeof(int)); 
    if (fibonacci == NULL) { 
        printf("Error al asignar memoria.\n"); 
        return 1; 
    } 
 
    // Inicializar los primeros dos términos de Fibonacci 
    fibonacci[0] = 0; 
    fibonacci[1] = 1; 
 
    // Declarar las variables compartidas y privadas en la región paralela 
    #pragma omp parallel shared(fibonacci, n) 
    { 
        #pragma omp for 
        for (int i = 2; i < n; i++) { 
            // Usar una región crítica para evitar condiciones de carrera 
            #pragma omp critical 
            { 
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2]; 
            } 
        } 
    } 
 
    // Desplegar los resultados 
    printf("Serie de Fibonacci hasta %d términos:\n", n); 
    for (int i = 0; i < n; i++) { 
        printf("%d ", fibonacci[i]); 
    } 
    printf("\n"); 
 
    // Liberar memoria 
    free(fibonacci); 
 
    return 0; 
}
