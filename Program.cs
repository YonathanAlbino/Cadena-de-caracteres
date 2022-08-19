// See https://aka.ms/new-console-template for more information

/*Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
Mostrar el resultado en pantalla. Ejemplo:

CADENA FUENTE: “La mar estaba serena"
CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
CADENA RESULTADO: “Li mir estibi sereni"  */
            
            
            char [] cc = new char [30];
            char letra, caracter1, caracter2 = 'o';
            int acu = 0;

            Console.WriteLine("Ingrese el caracter a remplazar: ");
            caracter1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el caracter para remplazar ");
            caracter2 = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la frase que desea modificar letra por letra "+"corta con un punto");
            letra = char.Parse(Console.ReadLine());

            while(letra != '.' && acu < 29)
            {
                cc[acu] = letra;

            Console.WriteLine("Ingrese la frase que desea modificar letra por letra "+"corta con un punto");
            letra = char.Parse(Console.ReadLine());
            acu++;

            }

            cc[acu] = '\0';
            acu = 0;
        
            while(cc[acu] != '\0')
            {
                if(cc[acu] == caracter1)
                cc[acu] = caracter2;
                acu++;
            }

            acu = 0;
            
            Console.WriteLine("La frase modificada es: ");

            while(cc[acu] != '\0')
            {
                Console.Write(cc[acu]);
                acu++;
            }

