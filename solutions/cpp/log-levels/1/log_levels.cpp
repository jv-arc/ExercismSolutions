#include <string>

namespace log_line {
std::string message(std::string line) {
	int start = line.find(":") + 2;
	int size = line.length() - start;

	return line.substr(start,size);
}

std::string log_level(std::string line) {
	int open = line.find("[") +1;
	int close = line.find("]");
	int lenght = close-open;

	return line.substr(open,lenght);
}

std::string reformat(std::string line) {
	return message(line) + " (" + log_level(line) + ")";
}
}  // namespace log_line
