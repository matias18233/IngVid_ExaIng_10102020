RESPUESTAS - PARTE H

1. ¿C# permite herencia múltiple?
    Sí, por medio de interfaces


2. ¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
    Clase abstracta:
        Cuando necesito heredar a clases hijas una estructura determinada de atributos y métodos. Esta herencia se hará en forma jerárquica.
    Interfaz:
        Cuando debo heredar o implementar sólo métodos a clases hijas. El uso de interfaces permite la herencia múltiple.


3. ¿Qué implica una relación de Generalización entre dos clases?
    Esta relación representa la implementación de una clase abstracta en una clase hija.


4. ¿Qué implica una relación de Implementación entre una clase y una interfaz?
    Implica que una clase podrá utilizar los métodos disponibles en una interfaz, pero, para poder usarlos, deberán ser implementados dentro de dicha clase.


5. ¿Qué diferencia hay entre la relación de Composición y la Agregación?
    Relación de composición:
        - Si se dan varias relaciones, sus componentes no se comparten, y al momento de destruir un compuesto se destruyen todos los componentes.
        - Su cardinalidad permite una relación de "0 a 1" o "1".
        - Se la representa con una línea de relación con un prista en una de sus puntas (pintado).

    Relación de agregación:
        - Si se dan varias relaciones, sus componentes se comparten, y al momento de destruir un compuesto no se destruyen sus componentes.
        - Permite cualquier tipo de cardinalidad.
        - Se la representa con una línea de relación con un prista en una de sus puntas (sin pintar).


6. Indique V o F según corresponda. Diferencia entre Asociación y Agregación:
    a. Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.
        Verdadero

    b. Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1.
        Falso

    c. Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación.
        Falso