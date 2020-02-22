using System;
using System.Collections;
using System.Collections.Generic;

namespace Practical_5
{
    class Program
    {
        public void InfixToPostfix(ref string infix,out string postfix)
        {
            postfix = "";
            char ch;
            Stack<char> stack = new Stack<char>();

            for(int i=0;i<infix.Length;i++)
            {
                ch = infix[i];
                if(isOperator(ch))
                {
                    if(stack.Count==0)
                    {
                        stack.Push(ch);

                    }
                    else
                    {
                        if(ch=='(')
                        {
                            stack.Push(ch);
                        }
                        else if(ch==')')
                        {
                            while(stack.Peek()!='(')
                            {
                                postfix += stack.Pop();
                            }
                            stack.Pop();
                        }
                        else
                        {
                            if(Priority(ch)>Priority(stack.Peek()))
                            {
                                stack.Push(ch);
                            }
                            else 
                            {
                                postfix += stack.Pop();
                                i--;
                            }
                        }
                    }
                }
                else
                {
                    postfix += ch;
                }
            }
            foreach(var item in stack)
            {
                postfix += item;
            }
            Console.WriteLine(postfix);

        }
        public Boolean isOperator(char ch)
        {
            if(ch=='+'||ch=='-'|| ch == '*' || ch == '/' || ch == '(' || ch == ')')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Priority(char ch)
        {
            int pri = 0;
            
            switch(ch)
            {
                case '(':
                case ')': pri = 1;
                    return pri;

                case '+':
                case '-': pri = 2;
                    return pri;

                case '*':
                case '/':pri = 3;
                    return pri;

                default: return pri;

            }
        }
    }
}
