import os
import downloadVideoYoutube as dwlVid
import covertYTVideoToMusic as dwlMus

path = 'C:/Users/dat54/OneDrive/Desktop/Learning/python/downloadVideo/downloads'

choose = int(input('1. download Youtube video corvert\n2. download music video\ninput your seclection: '))
if choose == 1:
    link = input('enter your URL Youtube link covert to music: ')
    dwlMus.musicDownload([link],path)
else:
    link = input('enter your URL link download Youtube video: ')
    dwlVid.videoDownload([link],path)