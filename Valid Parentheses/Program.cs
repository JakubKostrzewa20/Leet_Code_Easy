public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> myStack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(')
            {
                myStack.Push(')');
            }
            else if (c == '[')
            {
                myStack.Push(']');
            }
            else if (c == '{')
            {
                myStack.Push('}');
            }
            else if (myStack.Count == 0 || myStack.Pop() != c)
            {
                return false;
            }
        }
        return myStack.Count == 0;
    }
}