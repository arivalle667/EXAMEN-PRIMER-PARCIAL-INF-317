import math

def fibonacci_binet(n):
    phi = (1 + math.sqrt(5)) / 2
    psi = (1 - math.sqrt(5)) / 2
    return round((phi**n - psi**n) / math.sqrt(5))

# Ejemplo de uso
n = int(input("Ingrese el término de la secuencia de Fibonacci que desea calcular: "))
resultado = fibonacci_binet(n)
print(f"El término {n} de la secuencia de Fibonacci es: {resultado}")
