namespace Menues
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
      public int Cantidad{
         get;
         set;
      }

      private int choriComun{
        get; 
        set;
      }
      private int choriVegano{
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