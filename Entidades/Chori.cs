namespace Choris
{
    public class Chori
    {
      public int EsVegano{
         get; 
         set;
      }
      public string Descripcion{
         get;
         set;
      }
      public float Precio{
         get;
         set;
      }

      public int choriComun{
         get; 
        set;
      }
      public int choriVegano{
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