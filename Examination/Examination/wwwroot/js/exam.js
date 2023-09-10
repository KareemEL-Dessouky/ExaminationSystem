document.getElementById('addQuestion').addEventListener('click', function () {
    var questionDiv = document.createElement('div');

    var questionTypeSelect = document.createElement('select');
    questionTypeSelect.name = 'Questions[0].QuestionType';
    questionTypeSelect.options[0] = new Option('Multiple choice', 'MCQ');
    questionTypeSelect.options[1] = new Option('True/False', 'TF');
    questionTypeSelect.options[2] = new Option('Fill in the blank', 'FB');
    questionDiv.appendChild(questionTypeSelect);

    var questionTextInput = document.createElement('input');
    questionTextInput.name = 'Questions[0].QuestionText';
    questionDiv.appendChild(questionTextInput);

    // Add more input elements for other question properties...

    document.getElementById('questions').appendChild(questionDiv);
});
