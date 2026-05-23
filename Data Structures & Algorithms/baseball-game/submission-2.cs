public class Solution {
    public int CalPoints(string[] operations) {
        int length = operations.Length;
        Stack<int> stack = new Stack<int>();
        int sum=0;
        for(int i=0;i<length;i++){
            switch(operations[i]){
                case "+":
                    int num1 = stack.Pop();
                    int num2 = stack.Peek();
                    stack.Push(num1);
                    stack.Push(num1 + num2);
                    sum = sum + (num1 + num2);
                    break;
                case "D":
                    int top = stack.Peek();
                    stack.Push(2*top);
                    sum+= (2*top);
                    break;
                case "C":
                    int c = stack.Pop();
                    sum-= c;
                    break;
                default:
                    int number = Convert.ToInt32(operations[i]);
                    stack.Push(number);
                    sum += number;
                    break;
            }
        }

        return sum;
    }
}