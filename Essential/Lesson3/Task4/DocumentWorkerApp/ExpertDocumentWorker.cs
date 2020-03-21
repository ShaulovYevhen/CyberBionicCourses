namespace DocumentWorkerApp
{
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override string SaveDocument()
        {
            return "Документ сохранен в новом формате";
        }
    }
}