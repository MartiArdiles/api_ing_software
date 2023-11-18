namespace Entidades
{
    public class Cliente 
    {  
     private Chori chori = new Chori();
       public string Name //esto es una property
       {
          get; 
          set;
       }
       public string SurName
       {
          get; 
          set;
       }
       public string Email
       {
          get; 
          set;
       }
       public string DocumentType
       {
          get; 
          set;
       }
       public long DocumentNumber
       {
          get; 
          set;
       }
       private int esVegano;
       public int EsVegano
       {
          get
          {
               return this.esVegano;
          } 
          set
          {
               this.esVegano = value;
               this.chori.EsVegano = value;
          }
       }
    }
}
