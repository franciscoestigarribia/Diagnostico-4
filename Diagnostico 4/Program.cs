



    int posicion = 0;
    string[] nombr = new string[posicion];
    int[] numeroparticipant = new int[posicion];
    string[] apellid = new string[posicion];
    double[] tempo = new double[posicion];
    int[] altur = new int[posicion];
    int[] categori = new int[posicion];
    
    
        
        int finalizar = 10;

        while (finalizar != 0)
        {
            Console.WriteLine("ingrese su numero de participante");
            numeroparticipante = int.Parse(Console.ReadLine());
            numeroparticipant[posicion] = numeroparticipante;
            if(numeroparticipante!=0)
            {
                Console.WriteLine("ingrese su nombre");
                Console.WriteLine("ingrese su apellido");
                Console.WriteLine("ingrese el tiempo que hizo");
                Console.WriteLine("ingrese su altura");
                Console.WriteLine("ingrese su categoria");
            }
            else
            {
                finalizar = 0;
            }

        }
       
    
   
    
        mejortiempo = tempo[0];
        for (int i = 0; i < numeroparticipante; i++)
        {

        }
    }









