// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
using namespace std;//considered to be un-professional

enum class Powers
{
    Money, Teleportation, MindReading
};

void printMyPower(Powers pow);

int main()
{
    Powers myPower = Powers::Money;
    printMyPower(myPower);

    //std -- standard namespace
    //:: -- scope resolution operator
    //<< -- insertion operator
    //cout -- console out stream
    std::cout << "Hello World!\n";

    char best[] = "Batman";//adds \0 null terminator
    char meh[] = { 'A','q','u','a','m','a','n', '\0'};

    cout << best << "\n" << meh << "\n";
    std::cout << sizeof(char) << " (bytes)\n";

    for (size_t i = 0; i < sizeof(best)/sizeof(char); i++)
    {

    }

    for (auto c : best)
    {
        cout << c << " ";
    }
    cout << "\n";

    srand((unsigned int)time(NULL));//seeds the random # generator
    int random = rand() % 101;//0-RAND_MAX (32767)

    vector<int> scores;
    scores.push_back(rand());
    scores.push_back(rand());
    scores.push_back(rand());
    scores.push_back(rand());
    scores.push_back(rand());
    scores.push_back(rand());

    for (size_t i = 0; i < scores.size(); i++)
    {
        cout << scores[i] << "\n";
    }

    for(auto score : scores)
        cout << score << "\n";

}

void printMyPower(Powers pow)
{
    switch (pow)
    {
    case Powers::Money:
        break;
    case Powers::Teleportation:
        break;
    case Powers::MindReading:
        break;
    default:
        break;
    }
}