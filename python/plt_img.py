import matplotlib.pyplot as plt
import matplotlib.image as img
image = img.imread("C:\\Users\\dat54\\OneDrive\\Desktop\\avt.jpg")
fig, axs = plt.subplots(2,2,figsize = (2,2))
axs[0,0].imshow(image)
axs[1,1].imshow(image)
axs[1,0].imshow(image)
axs[0,1].imshow(image)

# save file
plt.savefig('a.jpg')
plt.savefig('a.pdf')
plt.show()