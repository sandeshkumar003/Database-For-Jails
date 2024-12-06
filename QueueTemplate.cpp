#include <iostream>
using namespace std;


template <typename S>
class Node
{
public:
    S value;
    Node *next;
};
template <class A>
class Queue
{
   

public:
    Node<A> *front;
    Node<A> *rear;
    Queue()
    {
        front = NULL;
        rear = NULL;
    }
    void Enqueue(A Data)
    {
        Node<T> *newnode = new Node<T>;
        newnode->value = Data;
        newnode->next = NULL;

        if (front == NULL)
        {
            front = newnode;
            rear = newnode;
        }
        else
        {
            Node<T> *temp;

            rear->next = newnode;
            rear = newnode;
        }
    }
    A Dequeue()
    {
        A oldfront;
        if (front != NULL)
        {
            Node<A> *temp;
            oldfront = front->value;
            temp = front->next;
            delete front;
            front = temp;
        }

        if (front == NULL)
        {
            rear = NULL;
        }
        return oldfront;
    }

    string is_empty()
    {
        if (front == NULL && rear == NULL)
        {
            return "true";
        }
        return "false";
    }
    ~Queue()
    {
        delete front;
        delete rear;
    }
};
int main()
{
    Queue <int> q1;
    q1.Enqueue(50);
    q1.Enqueue(70);
    q1.Enqueue(60);
    cout<<q1.Dequeue()<<endl;
    cout<<q1.Dequeue()<<endl;
    cout<<q1.Dequeue()<<endl;
     Queue <string> q2;
    q2.Enqueue("Implementing");
    q2.Enqueue("Queue");
    q2.Enqueue("Template");
    cout<<q2.Dequeue()<<endl;
    cout<<q2.Dequeue()<<endl;
    cout<<q2.Dequeue()<<endl;

}