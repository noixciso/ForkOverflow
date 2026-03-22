using ForkOverflow.Contracts;

namespace ForkOverflow.Application
{
    public class QuestionsService
    {
        public async Task Create(CreateQuestionDto request, CancellationToken cancellationToken)
        {
            //валидация данных из запроса(DTO)

            //создание сущности Question на основе данных из запроса

            //сохранение сущности Question в базе данных

            //логирование об успешном/неуспешном создании вопроса
        }

        public async Task Update(
            Guid questionId,
            UpdateQuestionDto request,
            CancellationToken cancellationToken)
        {
        }

        public async Task Delete(Guid questionId, CancellationToken cancellationToken)
        {
        }

        public async Task SelectSolution(
            Guid questionId,
            Guid answerId,
            CancellationToken cancellationToken)
        {
        }

        public async Task AddAnswer(
            Guid questionId,
            AddAnswerDto request,
            CancellationToken cancellationToken)
        {
        }
    }
}
