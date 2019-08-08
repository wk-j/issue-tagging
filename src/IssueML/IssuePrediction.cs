using Microsoft.ML.Data;
namespace IssueML
{
    public class IssuePrediction
    {
        [ColumnName("PredictedLabel")]
        public string Area;
    }
}