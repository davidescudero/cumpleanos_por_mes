// solicitar al grupo cuantas personas cumplen en cada mes 
//guardar los datos en un vector
//imprimir la cantidad de personas que cumplen cada mes
//mostrar cual es el mes con mayor cantidad
//mostrar cual es el mes con menor cantidad de cumpleañeros
//mostrar el promedio de cumpleaños por mes

int[] cumplen = new int[12];
string[] mes = new string[]{"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
double sum= 0;
for (int i = 0 ; i< mes.Length;i++){
    Console.WriteLine("Cuantas personas cumplen en "+ mes[i]);
    cumplen[i] = Int32.Parse(Console.ReadLine());

    sum = sum + cumplen[i];
}


int men;

int mayor;
    int posMayor = 0;
    int posMenor = 0;

for (int j = 0 ; j< mes.Length;j++){
    Console.WriteLine("En el mes de " + mes[j] + " cumplen años " + cumplen[j] + " Alumnos");
    men = cumplen[0];
         if(cumplen[j] < men)
        {
            men = cumplen[j];
            posMenor = j;
        }   

    mayor = cumplen[0];
         if(cumplen[j] > mayor)
        {
            mayor = cumplen[j];
            posMayor = j;
        }   
    
}

Console.WriteLine("Mes con mayor cantidad  " + mes[posMayor])   ; 
Console.WriteLine("Mes con menor cantidad  " + mes[posMenor])   ; 
Console.WriteLine("promedio  " + (sum-1)/12)   ; 


