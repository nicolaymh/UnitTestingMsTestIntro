# UnitTestingMsTestIntro

Este proyecto es un ejemplo básico de cómo implementar pruebas unitarias utilizando MSTest en C#.

## Estructura del Proyecto

```plaintext
UnitTestingMsTestIntro/
├── UnitTestingMsTestIntro/
│ ├── Calcs.cs
│ ├── CollectionsSample.cs
├── Tests/
│ ├── CalcTests.cs
│ ├── CollectionSampleTests.cs


- **UnitTestingMsTestIntro**: Contiene la lógica de negocio.
  - `Calcs.cs`: Contiene métodos para operaciones matemáticas básicas como sumar, restar y multiplicar.
  - `CollectionsSample.cs`: Define la clase `Customer` y un método para obtener un cliente de una lista.

- **Tests**: Contiene las pruebas unitarias para el proyecto.
  - `CalcTests.cs`: Pruebas unitarias para verificar las operaciones matemáticas en `Calcs.cs`.
  - `CollectionSampleTests.cs`: Pruebas unitarias para verificar la manipulación de colecciones en `CollectionsSample.cs`.

## Requisitos

- .NET SDK
- MSTest

## Descripción General del Código

### Calcs.cs
Define métodos estáticos para realizar operaciones matemáticas básicas:
- `Add(int a, int b)`: Suma dos números.
- `Subtract(int a, int b)`: Resta dos números.
- `Multiply(int a, int b)`: Multiplica dos números.

### CollectionsSample.cs
Define la clase `Customer` y un método para manipular colecciones:
- `GetCustomer(Customer[] customers, int index)`: Obtiene un cliente de un arreglo en la posición especificada.

### CalcTests.cs
Contiene pruebas unitarias para los métodos en `Calcs.cs` utilizando decoradores `[DataRow]` para probar diferentes casos:
- `Sum_ShouldCalcAndReturnSameValue()`: Verifica la suma de dos números.
- `Subtract_ShouldCalcAndReturnSameValue()`: Verifica la resta de dos números.
- `Multiply_ShouldCalcAndReturnSameValue()`: Verifica la multiplicación de dos números.

### CollectionSampleTests.cs
Contiene pruebas unitarias para el método `GetCustomer` en `CollectionsSample.cs`:
- `GetCustomer_ShouldGetSameCustomer()`: Verifica que se obtenga el cliente correcto de la lista.
- `GetCustomer_ShouldThrowIndexOutofRangeException()`: Verifica que se lance una excepción cuando el índice está fuera de rango.

---


