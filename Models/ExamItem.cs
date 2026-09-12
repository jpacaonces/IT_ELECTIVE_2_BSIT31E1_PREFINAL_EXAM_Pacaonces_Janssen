namespace IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Pacaonces_Janssen.Models;

public class ExamItem
{
    public int Id { get; set; }
    public string Question { get; set; } = string.Empty;
    public List<string> Options { get; set; } = [];
    public string CorrectAnswer { get; set; } = string.Empty;
    public string Explanation { get; set; } = string.Empty;
}