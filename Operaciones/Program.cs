using System;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            double numero1, numero2;

            Console.WriteLine("BIENVENIDO");

            do{
                
                Console.WriteLine("\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Módulo\n6. Salir\n");

                Console.WriteLine("Ingresa una opción: ");
                op = Convert.ToInt32(Console.ReadLine());

                if(op == 1){

                    Console.WriteLine("Ha selecionado la suma");
                    Console.WriteLine("Ingrese el la primer cantidad");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la segunda cantidad");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("El resultado de la suma de las cantidades " + numero1 + " + " + numero2 + " = " + (numero1+numero2));

                }else{

                    if(op == 2){

                        Console.WriteLine("Ha selecionado la resta  ");
                        Console.WriteLine("Ingrese el la primer cantidad");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda cantidad");
                        numero2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("El resultado de la resta de las cantidades " + numero1 + " - " + numero2 + " = " + (numero1-numero2));
                    }else{
                    
                        if(op == 3){

                            Console.WriteLine("Ha selecionado la multiplicación");
                            Console.WriteLine("Ingrese el la primer cantidad");
                            numero1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese la segunda cantidad");
                            numero2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("El resultado de la multiplicación de las cantidades " + numero1 + " * " + numero2 + " = " + (numero1*numero2));
                        }else{

                            if(op == 4){
                                Console.WriteLine("Ha selecionado la división");
                                Console.WriteLine("Ingrese el la primer cantidad");
                                numero1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Ingrese la segunda cantidad");
                                numero2 = Convert.ToDouble(Console.ReadLine());

                                if(numero2 == 0){

                                    Console.WriteLine("Eror!\nEl divisor no puede ser 0");

                                }else{

                                    Console.WriteLine("El resultado de la división de las cantidades " + numero1 + " / " + numero2 + " = " + (numero1/numero2));

                                }

                            }else{

                                if(op == 5){

                                    Console.WriteLine("Ha selecionado el módulo");
                                    Console.WriteLine("Ingrese el la primer cantidad");
                                    numero1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Ingrese la segunda cantidad");
                                    numero2 = Convert.ToDouble(Console.ReadLine());

                                    if(numero2 == 0){

                                        Console.WriteLine("Eror!\nEl divisor no puede ser 0");

                                    }else{

                                        Console.WriteLine("El resido de la división entre " + numero1 + " % " + numero2 + " = " + (numero1%numero2));

                                    }
                                    
                                }else{

                                    Console.WriteLine("Ha salio de las operaciones\nFin del programa");

                                }

                            }

                        }

                    }

                }
                
                while(op > 6 || op <= 0){

                    Console.WriteLine("Opción no disponible");
                    Console.WriteLine("¿Desea realizar otra operación?\n1. Sí\n2. No");
                    op = Convert.ToInt32(Console.ReadLine());

                }

            }while(op != 6);

            Console.ReadKey();

        }
        
    }
}
