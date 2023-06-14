# Code Kata - Mars Rover

## Enunciado Code Kata
Implementar un programa que controle el movimiento de un Rover en la superficie de Marte, siguiendo una serie de instrucciones dadas.

El Rover se puede mover alrededor de una cuadrícula, que por simplificación, se asume que es plana (en vez de esférica como lo sería un planeta real). La cuadrícula es rectangular y puede tener cualquier tamaño. Por defecto se asume que tiene un tamaño de 10x10.

Cada posición está definida por un par de coordenadas (x, y). El Rover también puede estar orientado en una de las cuatro direcciones posibles: norte, sur, este u oeste.

El Rover recibe comandos para saber cómo debe moverse. Los comandos son los siguientes:
- M - mover una celda en la dirección en la que se encuentra el Rover
- R - girar a la derecha 90 grados (sin moverse de la celda)
- L - girar a la izquierda 90 grados (sin moverse de la celda)

Si el Rover se encuentra al borde de la cuadrícula y recibe un comando para moverse fuera de la cuadrícula, el Rover simplemente no se moverá.

El objetivo del ejercicio es implementar un programa que procese las instrucciones dadas y calcule tanto su posición como su orientación final.

## Requisitos
Es necesario disponer del siguiente software instalado:

- .NET 6

## Ejecución
Desde la carpeta de la solución ejecutar el siguiente comando:

```
dotnet run --project .\MarsRover
```
