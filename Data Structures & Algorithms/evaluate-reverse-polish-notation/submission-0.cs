public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach(string s in tokens){
            if(s=="+" || s=="-" || s=="*" || s=="/"){
                int num2 = stack.Pop();
                int num1 = stack.Pop();
                int result;
                switch(s){
                    case "+":
                        stack.Push(num1+num2);
                        break;
                    case "-":
                        stack.Push(num1-num2);
                        break;
                    case "*":
                        stack.Push(num1*num2);
                        break;
                    case "/":
                        stack.Push(num1/num2);
                        break;
                }
            }
            else{
                stack.Push(Convert.ToInt32(s));
            }
        }

        return stack.Peek();
    }
}
