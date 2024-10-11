def fibonacci_con_vector(n):
    # Manejo de casos base
    if n == 0:
        return 0
    elif n == 1:
        return 1
    
    # Iniciamos el vector con los términos base de Fibonacci
    fib_vector = [0, 1]
    
    # Cálculo iterativo, actualizando el vector en cada paso
    for _ in range(2, n + 1):
        # Calculamos el siguiente término
        siguiente = fib_vector[0] + fib_vector[1]
        
        # Actualizamos el vector con el nuevo término
        fib_vector[0] = fib_vector[1]
        fib_vector[1] = siguiente
    
    # Retornamos el último término calculado
    return fib_vector[1]

# Pedir al usuario que ingrese el término deseado
try:
    n = int(input("Ingrese el término de la secuencia de Fibonacci que desea calcular: "))
    if n < 0:
        print("Por favor ingrese un número entero no negativo.")
    else:
        resultado = fibonacci_con_vector(n)
        print(f"El término {n} de la secuencia de Fibonacci es: {resultado}")
except ValueError:
    print("Por favor ingrese un número entero válido.")
