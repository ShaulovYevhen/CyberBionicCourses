namespace DocumentWorkerApp
{
    public class DocumentWorker
    {
        public string OpenDocument()
        {
            return "Документ открыт";
        }

        public virtual string EditDocument()
        {
            return "Редактирование документа доступно в версии Про";
        }

        public virtual string SaveDocument()
        {
            return "Сохранение документа доступно в версии Про";
        }
    }
}