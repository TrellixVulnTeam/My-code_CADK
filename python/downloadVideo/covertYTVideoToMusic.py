from __future__ import unicode_literals
import youtube_dl
import os

def musicDownload(link,path):
    os.chdir(path)
    def my_hook(d):
        if d['status'] == 'finished':
            print('Done download, now coverting...')
    ydl_opts = {
        'progress_hooks': [my_hook],
        'format': 'bestaudio/best',
        'postprocessors': [{
            'key': 'FFmpegExtractAudio',
            'preferredcodec': 'mp3',
            'preferredquality': '192',
        }],   
    }
    with youtube_dl.YoutubeDL(ydl_opts) as ydl:
        ydl.download(link)