namespace Properti.Assessment.Operations;

// Interface for operations
public interface IOperation
{
     //calculate to operation
     double toResult();

     //string process this method help us print process to using contains operation
     string toStringProcess();
     
     //print to operation
     string print();
     
     //print sentence to operation
     string printSentence();

}