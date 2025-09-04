from tkinter import *
root = Tk()

root.title("OLD WINDOW")
root.geometry("400x100")

def open():
    new = Toplevel()
    new.title("NEW WINDOW")
    new.geometry("300x100")
    
    label = Label(new, text="Hello, this is new window!")
    label.pack()

    B2 = Button(new, text="EXIT", command=new.quit)
    B2.pack()

L1 = Label(root, text="I am OLD WINDOW!")
L1.pack()

B1 = Button(root, text="Click this for NEW WINDOW!", command=open)
B1.pack()

mainloop()