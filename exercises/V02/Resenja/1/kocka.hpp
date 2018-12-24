#ifndef ZAGLAVLJE_H_INCLUDED
#define ZAGLAVLJE_H_INCLUDED

#include <iostream>
#include <cstdlib> // srand, rand
#include <ctime> // time

using namespace std;

class Kocka{
    private:
        int vrednost;
    public:
        Kocka();
        Kocka(int);
        Kocka(const Kocka &);

        void baci();
        int getVrednost() const;
};

#endif // ZAGLAVLJE_H_INCLUDED
