namespace Entidades
{
    public class Chori
    {

       public int choriComun{
         get; 
        set;
       }
       public int choriVegano{
        get; 
        set;
       }

       public int EsVegano{
         get; 
         set;
       }
       public void SumarizarChori(){

         if(this.EsVegano == 1){
            choriVegano += 1;
         }
         else
         {
            choriComun += 1;
         }  
       }
    }
}