using Asistentes;

namespace Personas
{
   public class Persona 
   {  
      public int IDPersona//esto es una property
      {
         get; 
         set;
      }
      public string Nombre
      {
         get; 
         set;
      }
      public string Apellido
      {
         get; 
         set;
      }
      public string Email{
         get;
         set;
      }  

      public string NombreCompleto{
         get
         {
            return this.Nombre + " " + this.Apellido;
         }
      }
      private string Contraseña{
         get;
         set;
      }
      private bool EsAdmin{
        get;
        set;
      }

      public Asistente Asistente{
         get;
         set;
      }
      public Admin admin{
         get;
         set;
      }
   }
}