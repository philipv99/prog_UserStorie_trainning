using UserStorie_school_assignment.Class;

namespace UserStorie_school_assignment.Reposetorys
{
    public class MusicRecordsReposetory
    {
        public List<MusicRecord> Records { get; set; }


        public MusicRecordsReposetory()
        {
            Records = new List<MusicRecord>() {
            new MusicRecord() { Title = "man", Artist = "him", Duration = 200, Id = 1, PublicationYear = 2002 },
            new MusicRecord() { Title = "woman", Artist = "her", Duration = 400, Id = 2, PublicationYear = 2003 }};
        }


        public List<MusicRecord> Get()
        {
            return Records;
        }
    }
}
