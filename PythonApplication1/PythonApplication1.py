from datetime import datetime
import pytz

# Get current time in UTC
today = datetime.utcnow()

# Parse dates
birthday = datetime.strptime("25/12/1961", "%d/%m/%Y")
birthday2 = datetime.strptime("25/12/1961", "%d/%m/%Y")

# Print dates
print(birthday.strftime("%c"))
print(birthday2.strftime("%c"))

print(today.strftime("%c"))
print(today.strftime("%B %d, %Y %I:%M %p %z"))

