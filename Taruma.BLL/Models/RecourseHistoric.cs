namespace Taruma.BLL.Models
{
    public class RecourseHistoric
    {
        public int RecourceHistoricId { get; set; }

        public decimal Value { get; set; }

        public Tip Tips { get; set; }

        public int Day { get; set; }

        //Pertence
        public int MonthId { get; set; }
        public virtual Month Month { get; set; }
       
        public int Year { get; set; }
    }

    public enum Tip
    {
        Entrada, Saída
    }

}