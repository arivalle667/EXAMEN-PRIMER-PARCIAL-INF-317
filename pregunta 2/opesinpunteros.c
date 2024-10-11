#include <stdio.h> 
 
int suma(int a, int b) { 
    return a + b; 
} 
 
int resta(int a, int b) { 
    return a - b; 
} 
 
int multiplicacion(int a, int b) { 
    return a * b; 
} 
 
float division(int a, int b) { 
    if (b != 0) { 
        return (float)a / b; 
    } else { 
        printf("Error: División por cero.\n"); 
        return 0; 
    } 
} 
 
int main() { 
    int num1, num2, opcion; 
    float resultado; 
 
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
            printf("Resultado de la suma: %d\n", suma(num1, num2)); 
            break; 
        case 2: 
            printf("Resultado de la resta: %d\n", resta(num1, num2)); 
            break; 
        case 3: 
            printf("Resultado de la multiplicación: %d\n", multiplicacion(num1, num2)); 
            break; 
        case 4: 
            resultado = division(num1, num2); 
            if (num2 != 0) { 
                printf("Resultado de la división: %.2f\n", resultado); 
            } 
            break; 
        default: 
            printf("Opción no válida.\n"); 
            break; 
    } 
 
    return 0; 
}
