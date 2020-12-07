
import itertools as it
tr_count = int(input("Kaç transaction girilecek: "))
min_sup = int(input("Min sup: "))
transactions = list()
tr_str_list = list()
items = ["a","b","c","d","e"]
popularSet = list()
def item_kontrol(tr_str): #item a,b,c,d,e olmalı else: gecersiz giris yptiniz
	tr_str_approve = tr_str.split(" ")
	is_ok = 0
	for i in tr_str_approve:
		if(i==items[0] or i ==items[1] or i==items[2] or i==items[3] or i==items[4]):
			if(len(tr_str_approve)<6):
				is_ok = 1
			else:
				print("Fazla değer girdiniz")
				is_ok = 0
				break
			if tr_str_approve.count(items[0])>1 or tr_str_approve.count(items[1])>1 or tr_str_approve.count(items[2])>1 or tr_str_approve.count(items[3])>1 or tr_str_approve.count(items[4])>1:
				print("Aynı değeri 1 den fazla girmeyiniz")
				is_ok = 0
				break
			
		else:
			print("Geçersiz değer girdiniz")
			is_ok = 0
			break
	return is_ok

def support_calculate():
	item_index = find_longest_item()
	for i in range(1,len(transactions[item_index])+1):
		print("\n\n"+str(i)+" li alt kümeler support degerleri :")
		find_coefficient(list(it.combinations(transactions[item_index],i)))
	

def find_coefficient(combination_list):
	count_item = 0
	local_counter = 0
	for i in range(0,len(combination_list)):
		count_item = 0
		for item in transactions:
			if set(combination_list[i]).issubset(set(item)):
				count_item = count_item + 1
		if count_item >= min_sup:
			if(count_item > local_counter):
				local_counter = count_item
				popularSet.append(list(combination_list[i]))
			print (str(combination_list[i])+" kümesinin sup. degeri --> "+str(count_item))


def find_longest_item():
	temp = 0
	item_index = 0
	for index in range(0,len(transactions)):
		if(len(transactions[index])>temp):
			temp = len(transactions[index])
			item_index = index
	return item_index
	


for i in range(0,tr_count):
	control = 0
	while control == 0:
		tr_str = input("Transaction girin (format: a b c ): ")
		control = item_kontrol(tr_str) 
	tr_str_list.append(tr_str)
	tr_str2 = tr_str.split(" ")
	transactions.append(tr_str2)


support_calculate()

print("\n\nTransactionlar ve Itemlar")
for i in range(1,tr_count+1):
	print("T"+str(i)+"=>"+str(tr_str_list[i-1]))

print("\nApriori sonucunda En sık Geçen Item Kumesi")
print(popularSet[-1])
