using Models;
using Repositories;
using System.Collections.Generic;
using ViewModels;

namespace Services
{
    //logic
    public class PuzzleTaskService
    {
        private PuzzleTaskRepository _repository;

        public PuzzleTaskService(PuzzleTaskRepository repository)
        {
            _repository = repository;
        }

        public PuzzleTask Create(PuzzleTask task)
        {
            return _repository.Post(task);
        }

        public PuzzleTask Update(PuzzleTask task)
        {
            return _repository.Put(task);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }

        public List<PuzzleTask> GetAll()
        {

            return _repository.GetAll();
        }

        public PuzzleTask Get(long id)
        {
            return _repository.GetById(id);
        }


        //Kijkt of opgegeven antwoord hetzelfde is als 1 van de correcte antwoorden in de database
        public TaskValidationViewModel CheckIfTrue(PuzzleTask puzzleTask)
        {
            var pt = _repository.GetById(puzzleTask.Id);

                if (puzzleTask.Answer == pt.Answer)
                {
                    return new TaskValidationViewModel
                    {
                        IsCorrect = true
                    };

                }

            return new TaskValidationViewModel
            {
                IsCorrect = false
            };

        }
    }
}
