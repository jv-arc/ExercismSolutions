#!/usr/bin/env bash

string_to_read=$1
s_length=${#string_to_read}
result_string=''

for (( i=$s_length; i>=0; i-- )); do
	reversed_string+="${string_to_read:$i:1}"
done

echo "$reversed_string"





