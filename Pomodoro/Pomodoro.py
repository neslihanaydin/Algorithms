zaman = input("Başlangıç saatini giriniz (Exp: 17:20) : ")
zaman_bfr = str(zaman)
zaman = zaman.split(":")
saat = int(zaman[0])
dakika = int(zaman[1])
pomodoro = 0

for i in range(8):
	if(saat>22 or saat<9 ):
		print("Bugünlük bu kadar çalışma yeter..")
		break
	if(dakika+25<60):
		dakika = dakika+25
	elif(dakika+25==60):
		dakika = 0
		saat = saat+1
		if(saat == 24):
			saat = 0
	elif(dakika+25>60):
		saat = saat+1
		if(saat == 24):
			saat = 0
		dakika = (dakika+25)-60
	if(dakika<10):
		str_dakika = "0"+str(dakika)
	else:
		str_dakika = str(dakika)
	if(saat<10):
		str_saat = "0"+str(saat)
	else:
		str_saat = str(saat)
	zaman =str_saat+":"+str_dakika
	print(zaman_bfr+" - "+zaman+" --> Pomodoro "+str(i+1))
	pomodoro = pomodoro +1
	#print ("Pomodoro 1 -> "+zaman_bfr+" - "+zaman)
	mola_time = 5
	if( pomodoro ==4 ):
		mola_time = 30

	zaman_bfr = zaman
	if(dakika+mola_time<60):
		dakika = dakika+mola_time
	elif(dakika+mola_time==60):
		dakika = 0
		saat = saat+1
		if(saat == 24):
			saat = 0
	elif(dakika+mola_time>60):
		saat = saat+1
		if(saat == 24):
			saat = 0
		dakika = (dakika+mola_time)-60
	if(dakika<10):
		str_dakika = "0"+str(dakika)
	else:
		str_dakika = str(dakika)
	if(saat<10):
		str_saat = "0"+str(saat)
	else:
		str_saat = str(saat)
	zaman =str_saat+":"+str_dakika
	print(zaman_bfr+" - "+zaman+" --> MOLA")
	#print ("MOLA -> "+zaman_bfr+" - "+zaman)
	zaman_bfr = zaman

	# TODO : 4 pomodoro sonrası 30 dk mola ya da 2 pomodoro sonrası 20 dakika mola --done
	# Çalışma saatlerinin çıktısını bir dosyaya kaydet
	# Gece Saat 23'e kadar pomodoro çıktısı alsın. Ya da gün sonuna kadar --done
	# Her pomodoro için bir alarm kursun

