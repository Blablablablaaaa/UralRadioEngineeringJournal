namespace UralRadioEngineeringJournal.Domain
{
    public class Article
    {
        public Guid Id { get; set; }
        public string TitleRu { get; set; }
        public string TitleEn { get; set; }
        public string CitationRu { get; set; }
        public string CitationEn { get; set; }
        public string AnnotationRu { get; set; }
        public string AnnotationEn { get; set; }
        public string KeyWordsRu { get; set; }
        public string KeyWordsEn { get; set; }
        public List<string> LiteratureList { get; set; }
    }
}
