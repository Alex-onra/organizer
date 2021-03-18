namespace OrganizerB
{
    public class HockeyRowModel
    {
        public HockeyRowModel()
        {

        }

        public HockeyRowModel(int id,
                                 string surname,
                                 string command, 
                                 int count,
                                 int transfers ,
                                 int penaltys)
        {
            this.id = id;
            this.surname = surname;
            this.command = command;
            this.count = count;
            this.transfers = transfers;
            this.penaltys = penaltys;
        }
        public int id { get; set; }
        public string surname { get; set; }
        public string command { get; set; }
        public int count { get; set; }
        public int transfers { get; set; }
        public int penaltys { get; set; }
    }
}
