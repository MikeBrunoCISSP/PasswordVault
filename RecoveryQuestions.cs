using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordVault2
{
    public class Question
    {
        public int index;
        public string text;

        public void create(int indx, string q)
        {
            index = indx;
            text = q;
        }
    } //class Question

    public class RecoveryQuestions
    {
        private List<Question> questions;
        public List<Question> get_fullList() { return questions; }

        public List<string> buildQuestionList()
        {
            List<string> questions = new List<string>();

            questions.Add(@"In what city was your mother born?");
            questions.Add(@"What was the name of your first pet?");
            questions.Add(@"What was the model of your first car?");
            questions.Add(@"What was the name of your elementary school?");
            questions.Add(@"What is your mother's maiden name?");
            questions.Add(@"In what year was your mother born?");
            questions.Add(@"In what year was your father born?");
            questions.Add(@"Who was your best friend in elementary school?");
            questions.Add(@"Who was your childhood hero?");
            questions.Add(@"What is the name of your favorite movie?");
            questions.Add(@"What is the name of your favorite book?");

            return questions;
        }

        public void create()
        {
            int index = 0;
            Question q;
            List<string> questionList = buildQuestionList();
            questions = new List<Question>();

            foreach (string question in questionList)
            {
                q = new Question();
                q.create(index++, question);
                questions.Add(q);
            }
        }

        public string get_text(int index)
        {
            foreach (Question question in questions)
            {
                if (question.index == index)
                    return question.text;
            }

            return null;
        }

        public int get_index(string txt)
        {
            foreach (Question question in questions)
            {
                if (question.text == txt)
                    return question.index;
            }

            return -1;
        }

        public List<string> get_allQuestions()
        {
            List<string> allQuestions = new List<string>();
            foreach (Question q in questions)
                allQuestions.Add(q.text);

            return allQuestions;
        }

        public List<string> get_subset(string q)
        {
            List<string> subset = new List<string>();

            foreach (Question question in questions)
            {
                if (question.text != q)
                    subset.Add(question.text);
            }

            return subset;
        }

        public List<string> get_subset(string q1, string q2)
        {
            List<string> subset = new List<string>();

            foreach (Question question in questions)
            {
                if ((question.text != q1) && (question.text != q2))
                    subset.Add(question.text);
            }

            return subset;
        }
    } //class RecoveryQuestions
}
