#include <iostream>
#include <memory>
struct Node{
    std::shared_ptr<Node> next = nullptr;
    int value;
    Node(const int $value): value(value){}
};

int main(){
    std::shared_ptr<Node> head = nullptr, current = head;
    int number;
    while(std::cin >> number) {
        if(head == nullptr){
            current = head
                = std::make_shared<Node>(number);
        }else{
            std::shared_ptr<Node> newTail
                = std::make_shared<Node>(number);
            current->next=newTail;
            current = newTail;
        }
    }
    if(head == nullptr) return 0;
    current = head;
    do{
        std::cout<<current->value<<'\n';
        current = current->next;
    }while(current!=nullptr);
}