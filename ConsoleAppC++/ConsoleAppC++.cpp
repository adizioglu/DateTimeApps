#include <iostream>
#include <iomanip>
#include <ctime>
#include <sstream>

std::tm parseDate(const std::string& dateStr, const std::string& format) {
    std::tm tm = {};
    std::istringstream ss(dateStr);
    ss >> std::get_time(&tm, format.c_str());
    return tm;
}

std::string formatDate(const std::tm& tm, const std::string& format) {
    std::ostringstream ss;
    ss << std::put_time(&tm, format.c_str());
    return ss.str();
}

int main() {
    // Get current time in UTC
    std::time_t t = std::time(nullptr);
    std::tm today = *std::gmtime(&t);

    // Parse dates
    std::tm birthday = parseDate("25/12/1961", "%d/%m/%Y");
    std::tm birthday2 = parseDate("25/12/1961", "%d/%m/%Y");

    // Print dates
    std::cout << formatDate(birthday, "%c") << std::endl;
    std::cout << formatDate(birthday2, "%c") << std::endl;

    std::cout << formatDate(today, "%c") << std::endl;
    std::cout << formatDate(today, "%B %d, %Y %I:%M %p %z") << std::endl;

    return 0;
}
