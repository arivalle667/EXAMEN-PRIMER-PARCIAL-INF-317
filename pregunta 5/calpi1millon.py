import multiprocessing as mp

# Función para calcular una porción de la serie de Leibniz
def calcular_pi_parcial(start, end):
	pi_parcial = 0.0
	for i in range(start, end):
		pi_parcial += (1 if i % 2 == 0 else -1) * (4.0 / (2 * i + 1))
	return pi_parcial
def main():
	# Número de términos para calcular pi
	num_terminos = 1000000

	# Número de procesos (utilizamos 3 o más procesadores)
	num_procesos = 3

	# Dividir el rango de trabajo entre los procesos
	rango_por_proceso = num_terminos // num_procesos
	rangos = [(i * rango_por_proceso, (i + 1) * rango_por_proceso) for i in range(num_procesos)]

	# Crear un pool de procesos
	with mp.Pool(processes=num_procesos) as pool:
		# Calcular los valores de pi parciales en paralelo
        	resultados = pool.starmap(calcular_pi_parcial, rangos)

	# Sumar los resultados parciales para obtener el valor final de pi
	pi_total = sum(resultados)

	print(f"Valor aproximado de pi usando {num_terminos} términos: {pi_total:.15f}")

if __name__ == "__main__":
    main()
