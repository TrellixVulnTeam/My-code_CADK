import os
import urllib

path = "C:/Users/dat54/OneDrive/Desktop"

os.chdir(path)
link = input('enter URL video link: ')
file_name = 'tr'

urllib.request.urlretrieve(link, 'video_name.mp4') 
