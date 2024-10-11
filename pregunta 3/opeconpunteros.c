#include <stdio.h> 
 
void suma(int *a, int *b, int *resultado) { 
    *resultado = *a + *b; 
} 
 
void resta(int *a, int *b, int *resultado) { 
    *resultado = *a - *b; 
} 
 
void multiplicacion(int *a, int *b, int *resultado) { 
    *resultado = *a * *b; 
} 
 
void division(int *a, int *b, float *resultado) { 
    if (*b != 0) { 
        *resultado = (float)(*a) / *b; 
    } else { 
        printf("Error: División por cero.\n"); 
        *resultado = 0; 
    } 
} 
 
int main() { 
    int num1, num2, opcion; 
    int resultadoEntero; 
    float resultadoFloat; 
 
    printf("Ingrese el primer número: "); 
    scanf("%d", &num1); 
 
    printf("Ingrese el segundo número: "); 
    scanf("%d", &num2); 
 
    printf("Seleccione la operación a realizar:\n"); 
    printf("1. Suma\n"); 
    printf("2. Resta\n"); 
    printf("3. Multiplicación\n"); 
    printf("4. División\n"); 
    printf("Opción: "); 
    scanf("%d", &opcion); 
 
    switch(opcion) { 
        case 1: 
            suma(&num1, &num2, &resultadoEntero); 
            printf("Resultado de la suma: %d\n", resultadoEntero); 
            break; 
        case 2: 
            resta(&num1, &num2, &resultadoEntero); 
            printf("Resultado de la resta: %d\n", resultadoEntero); 
            break; 
        case 3: 
            multiplicacion(&num1, &num2, &resultadoEntero); 
            printf("Resultado de la multiplicación: %d\n", resultadoEntero); 
            break; 
        case 4: 
            division(&num1, &num2, &resultadoFloat); 
            if (num2 != 0) { 
                printf("Resultado de la división: %.2f\n", resultadoFloat); 
            } 
            break; 
        default: 
            printf("Opción no válida.\n"); 
            break; 
    } 
 
    return 0; 
}
