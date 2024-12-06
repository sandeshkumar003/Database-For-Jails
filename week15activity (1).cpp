#include <iostream>
using namespace std; 


template <typename D>  

struct Node{
    D data;
    Node *next;
};

template <class H>
 
class Queue{
    public:
    Node<int> *front,*rear;
    Queue()
    {
        front=NULL;
        rear = NULL;
    }
 
 
    void enqueue(H n)
    {
        Node<H> *temp=new Node<H>();
        if(temp==NULL){
            cout<<"Queue is full"<<endl;
            return;
            }
        temp->data=n;
        temp->next=NULL;
 
    
        if(front==NULL)
        {
            front=rear=temp;
        }
        else{
            rear->next=temp;
            rear=temp;
        }
        cout<<n<<" is in the queue. "<<endl;  
    }
 
    void show(){
        if(front==NULL){
            cout<<"Queue is not full"<<endl;
            return;
        }
        Node<H> *temp=front;
        //will check until NULL is not found
        while(temp){
            cout<<temp->data<<" ";
            temp=temp->next;
        }
        cout<<endl;
    }
    
    void  dequeue()
        {
        if (front==NULL)
        {
            cout<<"Queue has nothing inside as it got emptied"<<endl;
            return;
        }
        
        cout<<front->data<<" is being erased"<<endl;
        if(front==rear)
        {

            front = NULL;
            
            rear=NULL;
        }  
        else
            {
                front=front->next;}

        }
    
 
~Queue()
{
    while(front!=NULL)
    {
        Node<H> *temp=front;
        front=front->next;
        delete temp;
    }
    rear=NULL;
}   
};

int main()
{
    Queue<int> myQ;
    
 
    myQ.enqueue(50);
    myQ.enqueue(54);
    myQ.enqueue(34);
    myQ.enqueue(53);
    
     
    myQ.show();
     
    myQ.dequeue();
    myQ.dequeue();
    myQ.dequeue();
    myQ.dequeue();
    myQ.show();  
    return 0;
}