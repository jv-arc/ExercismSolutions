BEGIN {
    FS=","
}

function compose(d1, d2) {return (d1*10 + d2)}
function avg(n1, n2) {return (n1+n2)/2}

{   
    print "#" $1 ", " $2 " = " avg(compose($3,$4), compose($5,$6))
}
