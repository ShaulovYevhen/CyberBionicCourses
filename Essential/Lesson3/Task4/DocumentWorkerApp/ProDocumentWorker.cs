namespace DocumentWorkerApp
{
    public class ProDocumentWorker : DocumentWorker
    {
        public override string EditDocument()
        {
            return "Документ отредактирован";
        }

        public override string SaveDocument()
        {
            return "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт";
        }
    }
}