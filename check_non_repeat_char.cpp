#include <bits/stdc++.h>

using namespace std;

int main(){

	string str;

	cin >> str;
	map<char, int> m;
	for (int i = 0; i < str.length(); ++i)
	{
		cout << str[i] << "\n"; 
		m[str[i]]++;
	}
	bool overall_result = false;
	for (map<char, int>::iterator x = m.begin(); x != m.end(); ++x)
	{
		bool each = false;
		if(x->second == 1){
			each = true;
			overall_result = overall_result | each;
		}
	}

	if(overall_result){
		cout << "Yes\n";
	}
	else{
		cout << "No\n";
	}

}