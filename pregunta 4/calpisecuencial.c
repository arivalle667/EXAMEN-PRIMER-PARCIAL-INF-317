#include <stdio.h> 
 
// Función para calcular Pi de manera iterativa usando punteros 
void calcularPiIterativo(int n, double *pi) { 
    *pi = 0.0; 
    for (int i = 0; i < n; i++) { 
        *pi += (i % 2 == 0 ? 1.0 : -1.0) / (2.0 * i + 1.0); 
    } 
    *pi *= 4.0; 
} 
 
// Función para calcular Pi de manera recursiva usando punteros 
void calcularPiRecursivo(int n, int i, double *pi) { 
    if (i < n) { 
        *pi += (i % 2 == 0 ? 1.0 : -1.0) / (2.0 * i + 1.0); 
        calcularPiRecursivo(n, i + 1, pi); 
    } 
} 
 
int main() { 
    int terms; 
    double pi = 0.0; 
 
    printf("Ingrese el número de términos para el cálculo de Pi: "); 
    scanf("%d", &terms); 
 
    // Cálculo iterativo 
    calcularPiIterativo(terms, &pi); 
    printf("Pi calculado iterativamente: %.15f\n", pi); 
 
    // Reiniciamos el valor de pi para el cálculo recursivo 
    pi = 0.0; 
 
    // Cálculo recursivo 
    calcularPiRecursivo(terms, 0, &pi); 
    pi *= 4.0;  // Multiplicamos por 4 después de calcular la serie 
    printf("Pi calculado recursivamente: %.15f\n", pi); 
 
    return 0; 
}
