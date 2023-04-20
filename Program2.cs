


int menu;
CargarBoxeador();
Boxeador boxeador1;
Boxeador boxeador2;
do{
    System.Console.WriteLine("1. Cargar datos boxeador 1 \n2.cargar datos boxeador 2\n3.pelear \n4.salir.");
    menu = int.Parse(Console.ReadLine());
    switch(menu){
        case 1:
        boxeador1=CargarBox1();
        break;
        case 2:
        boxeador2=CargarBox2();
        break;
        case 3:
        GanadorPelea();
        break;
    }
}while(menu!=5);


Boxeador CargarBox1()
{
   string nom = Boxeador.IngresarTexto("Ingrese Nombre ");
    string pais = Boxeador.IngresarTexto("Ingrese su pais ");
    int peso = Boxeador.IngresarEntero("Ingrese su peso ");
    int pg = Boxeador.IngresarEntero("Ingrese la potencia de sus golpes ");
    if(pg<1 || pg>100)
    {
        pg = Boxeador.IngresarEntero("Ingrese la potencia de sus golpes ");
    }
    int vp  = Boxeador.IngresarEntero("Ingrese la velocidad de sus piernas ");
    if (vp<1 || vp>100)
    {
        vp  = Boxeador.IngresarEntero("Ingrese la velocidad de sus piernas ");
    }

    Boxeador boxeador1 =  new Boxeador(nom,pais,peso,pg,vp);
}

Boxeador CargarBox2()
{
   string nom = Boxeador.IngresarTexto("Ingrese Nombre ");
    string pais = Boxeador.IngresarTexto("Ingrese su pais ");
    int peso = Boxeador.IngresarEntero("Ingrese su peso ");
    int pg = Boxeador.IngresarEntero("Ingrese la potencia de sus golpes ");
    if(pg<1 || pg>100)
    {
        pg = Boxeador.IngresarEntero("Ingrese la potencia de sus golpes ");
    }
    int vp  = Boxeador.IngresarEntero("Ingrese la velocidad de sus piernas ");
    if (vp<1 || vp>100)
    {
        vp  = Boxeador.IngresarEntero("Ingrese la velocidad de sus piernas ");
    }

    Boxeador boxeador2 =  new Boxeador(nom,pais,peso,pg,vp);
}
Boxeador GanadorPelea(Boxeador boxeador1,Boxeador boxeador2)
{
    int diferencia;
    diferencia= boxeador1.ObtenerSkill() - boxeador2.ObtenerSkill();
  if (diferencia>=30)
  {
   System.Console.WriteLine("el"+ boxeador1.Nombre +"gano por KO");
  }else if (diferencia >= 10 && diferencia<30){
    System.Console.WriteLine("el" + boxeador1.Nombre + "gano por puntos en fallo uniname");
  }else if(diferencia>=0 && diferencia<10)
  {
    System.Console.WriteLine("el" + boxeador1.Nombre + "gano por puntos en fallo dividido");
  }
  else if(diferencia<0 && diferencia>-10)
  {
   System.Console.WriteLine("el" + boxeador2.Nombre + "gano por puntos en fallo dividido");
  }
  else if (diferencia <= -10 && diferencia>-30){
    System.Console.WriteLine("el" + boxeador2.Nombre + "gano por puntos en fallo uniname");
  }
 else if (diferencia<=-30)
  {
   System.Console.WriteLine("el"+ boxeador2.Nombre +"gano por KO");
  }
}
