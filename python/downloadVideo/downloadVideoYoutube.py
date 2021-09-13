import youtube_dl
import os

def videoDownload(link,path):
    os.chdir(path)
    ydl_opts = {
    }
    loop = 1

    while loop == 1:
        with youtube_dl.YoutubeDL(ydl_opts) as ydl:
            ydl.download(link)
        
        loop = int(input('you want to download more video? (input: 1)\nExit (input: 0): '))