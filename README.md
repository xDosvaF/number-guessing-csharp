# number-guessing-csharp

Juego de adivinar el número secreto, hecho en C# para consola.

El programa genera un número aleatorio y el jugador debe acertarlo. Tras cada intento indica si el número buscado es mayor o menor que el ingresado.

## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) 6.0 o superior

## Instalación

```bash
git clone https://github.com/xDosvaF/number-guessing-csharp.git
cd number-guessing-csharp
```

## Uso

```bash
dotnet run
```

Ejemplo de una partida:

```
Adivina el número (1-100): 50
Muy alto.
Adivina el número (1-100): 25
Muy bajo.
Adivina el número (1-100): 37
Correcto. Lo lograste en 3 intentos.
```

## Estructura del proyecto

```
number-guessing-csharp/
├── Program.cs
└── number-guessing-csharp.csproj
```

## Licencia

Distribuido bajo la licencia MIT. Consulta el archivo `LICENSE` para más información.
