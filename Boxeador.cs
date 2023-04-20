using System;
class Boxeador
{
    public string Nombre{get;set;}
    public string Pais{get;set;}
    public int Peso{get;set;}
    public int PotenciaGolpes{get;set;}
    public int VelocidadPiernas{get;set;}

    

    public Boxeador(string nom, string pais, int peso, int pg, int vp)
    {
        Nombre = nom;
        Pais=pais;
        Peso=peso;
        PotenciaGolpes = pg;
        VelocidadPiernas=vp;

    }
    public double ObtenerSkill()
    {
     double SkillFinal=0;
     double PGForm=0;
     double VPForm=0;
     Random Randnum = new Random();
     int NumRandom=Randnum.Next(1,10);
     VPForm=VelocidadPiernas*0.6;
     PGForm=PotenciaGolpes*0.8;
     
     SkillFinal=PGForm + VPForm + NumRandom;
     return SkillFinal;

    }
}