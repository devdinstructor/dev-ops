data segment
a dw 5h
b dw 4h
sum dw ?
data ends

code segment
assume cs: code ds :data
        begin:
              mov ax,data
              mov ds,ax
              mov ax,a
              add ax,b
              mov sum,ax
              mov ah,4ch
              int 21h
 code ends
 end begin
 end
                          
