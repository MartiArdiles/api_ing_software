using Personas;

namespace Asistentes
{
   public class Asistente : Persona
   {  
      public int IDChorifest
      {
         get; 
         set;
      }
      public int IDAsistente
      {
         get; 
         set;
      }
      public bool Asistio
      {
         get; 
         set;
      }
      public bool Pagado{
         get;
         set;
      } 
      public string Descripcion{
         get;
         set;
      } 
   }
}
